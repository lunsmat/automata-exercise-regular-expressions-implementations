// classes/Validators/QuestionOne/RealNumberValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class RealNumberValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^([+-]?)([0-9]+)((\.)([0-9]+))?$";
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
