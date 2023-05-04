// classes/Validators/QuestionTwo/BAlternativeValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class BAlternativeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(HM|MH)h*((mh*){2})*mh*$";
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
