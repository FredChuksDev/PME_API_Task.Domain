using PME_API_Task.Domain.Model;
using PME_API_Task.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PME_API_Task.Service.Implementation
{
    public class MemberService : IMemberServices
    {
        private readonly IMemberRepository _member;

        public MemberService(IMemberRepository member)
        {
            _member = member;
        }
        public Member CreateMember(Member member)
        {
            try
            {
                _member.CreateMember(member);
                return member;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Member DeleteMember(int id)
        {
            try
            {
                var member = _member.DeleteMember(id);
                return member;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Member GetMember(int id)
        {
            try
            {
                var  member = _member.GetMember(id);
                return member;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Member> GetMembers()
        {
            try
            {
                var memberList = _member.GetMembers();
                return memberList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Member UpdateMember(int id)
        {
            try
            {
                var member = _member.UpdateMember(id);
                return member;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
