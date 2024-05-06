using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Onboarding_API.Core.DbContext;
using Onboarding_API.Core.Dtos.FormDTO;
using Onboarding_API.Core.Entities.FormEntities;

namespace Onboarding_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        //Need Database inject using constr
        //Need AutoMapper inject using constr

        private readonly ApplicationDbContext _context;
        public IMapper _mapper;

        public FormsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        // Crud Functions

        //Create
        [HttpPost("create")]
        public async Task<IActionResult> CreateForm([FromBody] CreateOnBoardFormsDto createFormDto)
        {
            var newOnBoardForm = new OnBoardForm();

            _mapper.Map(createFormDto, newOnBoardForm);

            await _context.onboarding_POC.AddAsync(newOnBoardForm);
            await _context.SaveChangesAsync();

            return Ok("Forms saved successfull");

        }

        //Read All
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetOnBoardFormsDto>>> GetForms(string? q)
        {
            //Get Forms from Context
            // Check if we ha sarch parater or not and nullable check do that here.

            IQueryable<OnBoardForm> query = _context.onboarding_POC;

            if (q is not null)
            {
                query = query.Where(t => t.OwnerEmail != null && t.OwnerEmail.Contains(q));
            }

            var OnBoardForm = await query.ToListAsync();

            var convertedOnBoardingForms = _mapper.Map<IEnumerable<GetOnBoardFormsDto>>(OnBoardForm);

            return Ok(convertedOnBoardingForms);
        }


        [HttpGet("email/{OwnerEmail}")] // Route parameter required
        public async Task<ActionResult<GetOnBoardFormsDto>> GetFormsById([FromRoute] string OwnerEmail)
        {
            // Form veri bağlamını al ve var mı diye kontrol et
            var OnBoardForm = await _context.onboarding_POC.FirstOrDefaultAsync(t => t.OwnerEmail == OwnerEmail);
            if (OnBoardForm is null)
            {
                return NotFound("Form Data do not Find");
            }

            var convertedOnBoardingForms = _mapper.Map<GetOnBoardFormsDto>(OnBoardForm);
            return Ok(convertedOnBoardingForms);
        }

        //Update
        [HttpPut("edit/{id}")]

        public async Task<IActionResult> EditForms([FromRoute] long id, [FromBody] UpdateOnBoardFormsDto updateOnBoardFormsDto)
        {
            //get forms data context and check if it exist ? 

            var OnBoardForm = await _context.onboarding_POC.FirstOrDefaultAsync(t => t.Id == id);
            if (OnBoardForm is null)
            {
                return NotFound("Forms Data Not Found");
            }

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UpdateOnBoardFormsDto, OnBoardForm>();
            });

            _mapper = config.CreateMapper();
            _mapper.Map(updateOnBoardFormsDto, OnBoardForm);
            await _context.SaveChangesAsync();

            return Ok("Forms data has been successfully update");
        }

        //Delete
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteForms([FromRoute] long id)
        {
            //get forms data context and check if it exist ? 

            var OnBoardForm = await _context.onboarding_POC.FirstOrDefaultAsync(t => t.Id == id);
            if (OnBoardForm is null)
            {
                return NotFound("Forms Data Not Found");
            }

            _context.onboarding_POC.Remove(OnBoardForm);
            await _context.SaveChangesAsync();

            return Ok("Forms has been deleted successfully");

        }
    }
}