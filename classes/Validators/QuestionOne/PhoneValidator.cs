// classes/Validators/QuestionOne/PhoneValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class PhoneValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^((\([0-9]{2}\)\s9[0-9]{4}(-)?)|([0-9]{2}\s9[0-9]{4}))[0-9]{4}$";
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
