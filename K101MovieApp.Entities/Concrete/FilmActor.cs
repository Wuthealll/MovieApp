using K101MovieApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K101MovieApp.Entities.Concrete
{
    public class FilmActor: BaseEntity, IEntity
    {
        public int FIlmId { get; set; }
        public Film Film { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
