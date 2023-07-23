using PME_API_Task.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PME_API_Task.Service.Interfaces
{
    public interface IMemberRepository
    {
        List<Member> GetMembers();
        Member GetMember(int id);

        Member CreateMember(Member member);
        Member UpdateMember(int id);
        Member DeleteMember(int id);
    }
}
