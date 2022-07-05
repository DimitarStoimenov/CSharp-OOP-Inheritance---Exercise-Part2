namespace Animals
{
    using System;
    using System.Text;

    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name {
            get
            {
                return this.name;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.Name), "Name cannot be null");
                }

                this.name = value;
            } 
        }
        public int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(nameof(this.Age), "Age must be possitive number");
                }
                this.age = value;
            }
        }
        public string Gender 
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.Gender), "Name cannot be null or Whitespace");
                }
                this.gender = value;
            } 
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine($"{this.ProduceSound()}");

            return sb.ToString().TrimEnd();
        }

    }
}
