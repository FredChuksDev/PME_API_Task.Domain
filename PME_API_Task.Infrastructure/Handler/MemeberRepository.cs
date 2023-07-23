using Microsoft.EntityFrameworkCore;
using PME_API_Task.Domain.Model;
using PME_API_Task.Infrastructure.Data;
using PME_API_Task.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PME_API_Task.Infrastructure.Handler
{
    public class MemeberRepository : IMemberRepository
    {
        private readonly AppDbContext _context;

        public MemeberRepository(AppDbContext context)
        {
            _context = context;
        }
        public Member CreateMember(Member member)
        {
            try
            {
                _context.Members.Add(member);
                _context.SaveChanges();
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
                var member = _context.Members.FirstOrDefault(x => x.Id == id);
                _context.Members.Remove(member);
                _context.SaveChanges();
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
                var member = _context.Members.Find(id);
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
                var memberList = _context.Members.ToList();
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
                var member = _context.Members.Find(id);
                if(member != null)
                {
                    _context.Entry(member).State = EntityState.Modified;
                    _context.SaveChanges();
                }

                return member;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
