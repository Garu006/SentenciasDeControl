namespace Sesion4.clases
{
    /* Calcular el salario neto del empleado */
    internal class Empleado
    {
        public Empleado() { }
        public int ID { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }


        //Crear otro constructor
        public Empleado(int iD, string firstName, string lastName, string email, string phone, double salary)
        {
           this.ID = iD;
           this.FirstName = firstName;
           this.LastName = lastName;
           this.Email = email;
           this.Phone = phone;
           this.Salary = salary;
        }
        


    }
}
