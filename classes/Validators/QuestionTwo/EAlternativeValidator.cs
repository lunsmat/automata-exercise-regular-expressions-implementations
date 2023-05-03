using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class EAlternativeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(MM|HH)(h?(mh)*m?)$";
        }

        /**
         * H representa um homem;
         * M representa uma mulher;
         * h representa um filho do sexo masculino (natural ou adotado);
         * m representa uma filha do sexo feminimo (natural ou adotado);
         * A posição relativa de uma letra em relação às demais indica a idade relativa daquele
         * membro da família em relação aos demais (os mais novos estão sempre à direita).
         * Exemplo: a cadeia “MHhmm” representa uma família com um casal heterossexual em que a
         * mulher é mais velha que o homem. Além disso, esse casal possui três filhos, um homem e
         * duas mulheres, sendo que o filho homem é o mais velho dos três
         *
         * e. Casais homossexuais mais velhos que os filhos, em que o sexo dos filhos é alternado conforme a ordem de nascimento:
         */
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
