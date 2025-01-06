namespace Pratik17
{
    /// <summary>
    /// Represents an abstract employee class.
    /// </summary>
    public abstract class Calisan
    {
        /// <summary>
        /// Gets or sets the first name of the employee.
        /// </summary>
        public required string Ad { get; set; }

        /// <summary>
        /// Gets or sets the last name of the employee.
        /// </summary>
        public required string Soyad { get; set; }

        /// <summary>
        /// Gets or sets the department of the employee.
        /// </summary>
        public required string Departman { get; set; }

        /// <summary>
        /// Abstract method to define the task of the employee.
        /// </summary>
        public abstract void Gorev();
    }
}
