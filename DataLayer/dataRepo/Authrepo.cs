using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
    class Authrepo : IAuth

    {
        Entities project;
        public Authrepo(Entities db)
        {
            project = db;
        }
        public Token Authenticate(Systemuser user)
        {
            Token t = null;
            var use= (from u in project.Systemusers
                    where u.U_username.Equals(user.U_username) &&
                    u.U_password.Equals(user.U_password)
                    select u).FirstOrDefault();
            if (use != null)
            {
                var r = new Random();
                var g = Guid.NewGuid();
                var token = g.ToString();

                t = new Token()
                {
                    user_id = use.Id,
                    AccessToken = token,
                    CreatedAt = DateTime.Now

                };
                project.Tokens.Add(t);
                project.SaveChanges();

            }

            return t;


        }

        public Token IsAuthenticated(string token)
        {
            var ac_token = (from t in project.Tokens
                            where t.AccessToken.Equals(token) &&
                            t.ExpiredAt.Equals(null)
                            select t).FirstOrDefault();
            return ac_token;
            
        }

        public void Logout(int id)
        {
            var token = (from t in project.Tokens
                            where t.Id.Equals(id)
                            select t).FirstOrDefault();
            token.ExpiredAt = System.DateTime.Now;
            project.Entry(token).CurrentValues.SetValues(token);
            project.SaveChanges();
        }
    }
}
