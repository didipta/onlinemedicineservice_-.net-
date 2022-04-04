using DataLayer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.dataRepo
{
    class Tokenrepo : IRepository<Token, int>
    {
        Entities project;
        public Tokenrepo(Entities db)
        {
            project = db;
        }
        public bool Add(Token obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Token obj)
        {
            throw new NotImplementedException();
        }

        public Token Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

        public Token Getitem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
