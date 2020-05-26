using Janssen.Core.Web.CustomAttributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Janssen.Core.Web.Models
{
    public class Student
    {
        //        Id property:
        //is required for mapping the Common Language Runtime(CLR) object to the MongoDB collection.
        //is annotated with[BsonId] to designate this property as the document’s primary key.
        //is annotated with[BsonRepresentation(BsonType.ObjectId)] to allow passing the parameter as type string instead of ObjectId.Mongo handles the conversion from string to ObjectId.
        //Other properties in the class are annotated with the[BsonElement] attribute.The attribute’s value represents the property name in the MongoDB collection.

        //[YearRange] attribute is a custom attribute that allows only a valid range for the Year property.If you want to use this attribute, add CustomAttributes folder in the project as a new folder and add the following class there :


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("FirstName")]
        [Display(Name = "Name")]
        [Required]
        public string FirstName { get; set; }

        [BsonElement("PreviousSchool")]
        [Display(Name = "Previous School")]
        [Required]
        public string PrevSchool { get; set; }

        [BsonElement("YearBorn")]
        [Display(Name = "Year Born")]
        [Required]
        [YearRange]
        public int Year { get; set; }

        [BsonElement("Gender")]
        [Display(Name = "Gender(M/F)")]
        //[DisplayFormat(DataFormatString = "{0:#,0}")]
        public char Gender { get; set; }

        [BsonElement("ImageUrl")]
        [Display(Name = "Photo")]
        [DataType(DataType.ImageUrl)]
        [Required]
        public string ImageUrl { get; set; }
    }
}
