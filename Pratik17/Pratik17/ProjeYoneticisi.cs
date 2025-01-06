namespace Pratik17
{
    /// <summary>
    /// Represents a project manager who is an employee.
    /// </summary>
    public class ProjeYoneticisi : Calisan
    {
        /// <summary>
        /// Defines the task of the project manager.
        /// </summary>
        public override void Gorev()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }
    }
}
