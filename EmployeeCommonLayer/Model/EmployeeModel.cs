/// ================================================
/// File    : EmployeeModel.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
#region EmployeeCommonLayer.Model
namespace EmployeeCommonLayer.Model
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// POCO class for Employee
    /// </summary>
    #region EmployeeModel
    public class EmployeeModel
    {
        /// <summary>
        /// Gets or sets Employee Id
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets FirstName
        /// </summary>
        [Required(ErrorMessage = "FirstName Is Required")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName
        /// </summary>
        [Required(ErrorMessage = "LastName Is Required")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Email
        /// </summary>
        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets UserName
        /// </summary>
        [Required(ErrorMessage = "UserName Is Required")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        [Required(ErrorMessage = "Password Is Required")]
        [PasswordPropertyText]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets City
        /// </summary>
        public string City { get; set; }
    }
    #endregion
}
#endregion
