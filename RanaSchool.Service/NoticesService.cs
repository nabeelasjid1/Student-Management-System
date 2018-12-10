using RanaSchool.Database;
using RanaSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RanaSchool.Service
{
    public class NoticesService
    {
        public List<Notice> GetNotices()
        {
            using (var context = new RSContext())
            {
                return context.Notice.ToList();
            }
        }


        public Notice GetNotice(int ID)
        {
            using (var context = new RSContext())
            {
                return context.Notice.Find(ID);
            }
        }

        public void SaveNotice(Notice notice)
        {
            using (var context = new RSContext())
            {
                context.Notice.Add(notice);
                context.SaveChanges();
            }
        }
        public void UpdateNotice(Notice notice)
        {
            using (var context = new RSContext())
            {
                context.Entry(notice).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteNotice(int ID)
        {
            using (var context = new RSContext())
            {
                //context.Entry(teacher).State = System.Data.Entity.EntityState.Deleted;
                var notice = context.Notice.Find(ID);
                context.Notice.Remove(notice);
                context.SaveChanges();
            }
        }
    }
}
