



using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chinook.Entities
{
    /// <summary>
    /// Class Definition for Album
    /// </summary>
    public class Album
    {

        /// <summary>
        /// AlbumId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "AlbumId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Albumid { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [Required(ErrorMessage = "Title is required")]
        [StringLength(160, ErrorMessage = "Title has a maximum of 160 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Title { get; set; }

        /// <summary>
        /// ArtistId
        /// </summary>
        [Required(ErrorMessage = "ArtistId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Artistid { get; set; }
    }
    /// <summary>
    /// Class Definition for Artist
    /// </summary>
    public class Artist
    {

        /// <summary>
        /// ArtistId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "ArtistId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Artistid { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [StringLength(120, ErrorMessage = "Name has a maximum of 120 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Name { get; set; }
    }
    /// <summary>
    /// Class Definition for Customer
    /// </summary>
    public class Customer
    {

        /// <summary>
        /// CustomerId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "CustomerId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Customerid { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(40, ErrorMessage = "FirstName has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Firstname { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        [Required(ErrorMessage = "LastName is required")]
        [StringLength(20, ErrorMessage = "LastName has a maximum of 20 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Lastname { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        [StringLength(80, ErrorMessage = "Company has a maximum of 80 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Company { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [StringLength(70, ErrorMessage = "Address has a maximum of 70 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Address { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [StringLength(40, ErrorMessage = "City has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [StringLength(40, ErrorMessage = "State has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string State { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [StringLength(40, ErrorMessage = "Country has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Country { get; set; }

        /// <summary>
        /// PostalCode
        /// </summary>
        [StringLength(10, ErrorMessage = "PostalCode has a maximum of 10 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Postalcode { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [StringLength(24, ErrorMessage = "Phone has a maximum of 24 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Phone { get; set; }

        /// <summary>
        /// Fax
        /// </summary>
        [StringLength(24, ErrorMessage = "Fax has a maximum of 24 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Fax { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Required(ErrorMessage = "Email is required")]
        [StringLength(60, ErrorMessage = "Email has a maximum of 60 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Email { get; set; }

        /// <summary>
        /// SupportRepId
        /// </summary>
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int? Supportrepid { get; set; }
    }
    /// <summary>
    /// Class Definition for Employee
    /// </summary>
    public class Employee
    {

        /// <summary>
        /// EmployeeId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "EmployeeId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Employeeid { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        [Required(ErrorMessage = "LastName is required")]
        [StringLength(20, ErrorMessage = "LastName has a maximum of 20 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Lastname { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(20, ErrorMessage = "FirstName has a maximum of 20 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Firstname { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [StringLength(30, ErrorMessage = "Title has a maximum of 30 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Title { get; set; }

        /// <summary>
        /// ReportsTo
        /// </summary>
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int? Reportsto { get; set; }

        /// <summary>
        /// BirthDate
        /// </summary>
        [Column(TypeName = "DateTime")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public System.DateTime? Birthdate { get; set; }

        /// <summary>
        /// HireDate
        /// </summary>
        [Column(TypeName = "DateTime")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public System.DateTime? Hiredate { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [StringLength(70, ErrorMessage = "Address has a maximum of 70 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Address { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [StringLength(40, ErrorMessage = "City has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [StringLength(40, ErrorMessage = "State has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string State { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [StringLength(40, ErrorMessage = "Country has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Country { get; set; }

        /// <summary>
        /// PostalCode
        /// </summary>
        [StringLength(10, ErrorMessage = "PostalCode has a maximum of 10 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Postalcode { get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [StringLength(24, ErrorMessage = "Phone has a maximum of 24 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Phone { get; set; }

        /// <summary>
        /// Fax
        /// </summary>
        [StringLength(24, ErrorMessage = "Fax has a maximum of 24 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Fax { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [StringLength(60, ErrorMessage = "Email has a maximum of 60 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Email { get; set; }
    }
    /// <summary>
    /// Class Definition for Genre
    /// </summary>
    public class Genre
    {

        /// <summary>
        /// Genre ID
        /// </summary>
        [Key]
        [Required(ErrorMessage = "GenreId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "Genre ID", Prompt = "UID", Description = "UID")]
        public int Genreid { get; set; }

        /// <summary>
        /// Genre
        /// </summary>
        [StringLength(120, ErrorMessage = "Name has a maximum of 120 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "Genre", Prompt = "Enter a Genre (ie Jazz)", Description = "Musical Genre")]
        public string Name { get; set; }
    }
    /// <summary>
    /// Class Definition for Invoice
    /// </summary>
    public class Invoice
    {

        /// <summary>
        /// InvoiceId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "InvoiceId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Invoiceid { get; set; }

        /// <summary>
        /// CustomerId
        /// </summary>
        [Required(ErrorMessage = "CustomerId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Customerid { get; set; }

        /// <summary>
        /// InvoiceDate
        /// </summary>
        [Required(ErrorMessage = "InvoiceDate is required")]
        [Column(TypeName = "DateTime")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public System.DateTime Invoicedate { get; set; }

        /// <summary>
        /// BillingAddress
        /// </summary>
        [StringLength(70, ErrorMessage = "BillingAddress has a maximum of 70 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Billingaddress { get; set; }

        /// <summary>
        /// BillingCity
        /// </summary>
        [StringLength(40, ErrorMessage = "BillingCity has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Billingcity { get; set; }

        /// <summary>
        /// BillingState
        /// </summary>
        [StringLength(40, ErrorMessage = "BillingState has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Billingstate { get; set; }

        /// <summary>
        /// BillingCountry
        /// </summary>
        [StringLength(40, ErrorMessage = "BillingCountry has a maximum of 40 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Billingcountry { get; set; }

        /// <summary>
        /// BillingPostalCode
        /// </summary>
        [StringLength(10, ErrorMessage = "BillingPostalCode has a maximum of 10 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Billingpostalcode { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [Required(ErrorMessage = "Total is required")]
        [Column(TypeName = "Numeric")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public decimal Total { get; set; }
    }
    /// <summary>
    /// Class Definition for Invoiceline
    /// </summary>
    public class Invoiceline
    {

        /// <summary>
        /// InvoiceLineId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "InvoiceLineId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Invoicelineid { get; set; }

        /// <summary>
        /// InvoiceId
        /// </summary>
        [Required(ErrorMessage = "InvoiceId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Invoiceid { get; set; }

        /// <summary>
        /// TrackId
        /// </summary>
        [Required(ErrorMessage = "TrackId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Trackid { get; set; }

        /// <summary>
        /// UnitPrice
        /// </summary>
        [Required(ErrorMessage = "UnitPrice is required")]
        [Column(TypeName = "Numeric")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public decimal Unitprice { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [Required(ErrorMessage = "Quantity is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Quantity { get; set; }
    }
    /// <summary>
    /// Class Definition for Mediatype
    /// </summary>
    public class Mediatype
    {

        /// <summary>
        /// MediaTypeId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "MediaTypeId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Mediatypeid { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [StringLength(120, ErrorMessage = "Name has a maximum of 120 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Name { get; set; }
    }
    /// <summary>
    /// Class Definition for Playlist
    /// </summary>
    public class Playlist
    {

        /// <summary>
        /// PlaylistId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "PlaylistId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Playlistid { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [StringLength(120, ErrorMessage = "Name has a maximum of 120 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Name { get; set; }
    }
    /// <summary>
    /// Class Definition for Playlisttrack
    /// </summary>
    public class Playlisttrack
    {

        /// <summary>
        /// PlaylistId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "PlaylistId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Playlistid { get; set; }

        /// <summary>
        /// TrackId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "TrackId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Trackid { get; set; }
    }
    /// <summary>
    /// Class Definition for Track
    /// </summary>
    public class Track
    {

        /// <summary>
        /// TrackId
        /// </summary>
        [Key]
        [Required(ErrorMessage = "TrackId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Trackid { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required(ErrorMessage = "Name is required")]
        [StringLength(200, ErrorMessage = "Name has a maximum of 200 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Name { get; set; }

        /// <summary>
        /// AlbumId
        /// </summary>
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int? Albumid { get; set; }

        /// <summary>
        /// MediaTypeId
        /// </summary>
        [Required(ErrorMessage = "MediaTypeId is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Mediatypeid { get; set; }

        /// <summary>
        /// GenreId
        /// </summary>
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int? Genreid { get; set; }

        /// <summary>
        /// Composer
        /// </summary>
        [StringLength(220, ErrorMessage = "Composer has a maximum of 220 characters")]
        [Column(TypeName = "NVarChar")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public string Composer { get; set; }

        /// <summary>
        /// Milliseconds
        /// </summary>
        [Required(ErrorMessage = "Milliseconds is required")]
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int Milliseconds { get; set; }

        /// <summary>
        /// Bytes
        /// </summary>
        [Column(TypeName = "Int")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public int? Bytes { get; set; }

        /// <summary>
        /// UnitPrice
        /// </summary>
        [Required(ErrorMessage = "UnitPrice is required")]
        [Column(TypeName = "Numeric")]
        [Display(Name = "TBA", Prompt = "Please enter (TBA)", Description = "TBA")]
        public decimal Unitprice { get; set; }
    }
}
