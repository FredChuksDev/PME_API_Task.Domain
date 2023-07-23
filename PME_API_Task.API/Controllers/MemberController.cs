using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PME_API_Task.Domain.Model;
using PME_API_Task.Service.Interfaces;

namespace PME_API_Task.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberServices _memeberService;

        public MemberController(IMemberServices memeberService)
        {
            _memeberService = memeberService;
        }

        //Get; api/members
        [HttpGet]
        public ActionResult<List<Member>> Get()
        {
            var member = _memeberService.GetMembers();
            return Ok(member);  
        }

        //Get; api/members/{id}
        [HttpGet("{id}")]
        public ActionResult<Member> GetMember(int id)
        {
            var member = _memeberService.GetMember(id);
            if (member == null)
            {

                return NotFound();
            }
            return Ok(member);

        }

        //Post; api/members
        [HttpPost]
        public ActionResult<Member> CreateMember(Member member)
        {
           _memeberService.CreateMember(member);
            return CreatedAtAction(nameof(GetMember), new {id = member.Id}, member);
        }


        //Put; api/members/id
        [HttpPut("{id}")]
        public ActionResult UpdateMember(Member member, int id)
        {
           if(id != member.Id)
            {
                return NotFound();
            }
            _memeberService.UpdateMember(id);
            return NoContent();
        }

        //Delete; api/members/id
        [HttpDelete("{id}")]
        public ActionResult DeleteMember(int id)
        {
            _memeberService.DeleteMember(id);
            return NoContent();
        }

    }
}
