// classes/Validators/QuestionOne/DateTimeValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class DateTimeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^([0-9]{2}\/){2}[0-9]{4}\s([0-9]{2}:){2}[0-9]{2}$";
        }

        public bool validate(string arg)
        {
            Regex validator = new Regex(
                this.get_regex_pattern(),
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
