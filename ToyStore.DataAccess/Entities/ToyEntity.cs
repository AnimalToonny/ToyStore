using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore.DataAccess.Entities
{
    public class ToyEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public uint Price { get; set; }
    }
}
