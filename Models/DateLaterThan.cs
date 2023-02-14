// public class DateLaterThanAttribute : w0448225CourseMap
// {
//     private readonly string _comparisonProperty;

//     public DateLaterThanAttribute(string comparisonProperty)
//     {
//          _comparisonProperty = comparisonProperty;
//     }

//     protected override ValidationResult IsValid(object value, w0448225CourseMap w0448225CourseMapContext)
//     {
//         ErrorMessage = ErrorMessageString;
//         var currentValue = (DateTime)value;

//         var property = validationContext.ObjectType.GetProperty(_comparisonProperty);

//         if (property == null)
//             throw new ArgumentException("Property with this name not found");

//         var comparisonValue = (DateTime)property.GetValue(validationContext.ObjectInstance);

//         if (currentValue < comparisonValue)
//             return new ValidationResult(ErrorMessage);

//         return ValidationResult.Success;
//     }
// }