using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore.Core.Models
{
    public class Toy
    {
        public const int MaxSize = 100;

        private Toy(Guid id, string name, uint price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Guid Id { get; }

        public string Name { get; } = string.Empty;

        public uint Price { get; }

        public static (Toy Toy, string Error) Create(Guid id, string name, uint price)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(name) || name.Length > MaxSize)
            {
                error = $"name is empty or its lenght bigger then {MaxSize}";
            }

            var toy = new Toy(id, name, price);

            return (toy, error);
        }

    }
}
