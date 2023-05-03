using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class DAlternativeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(HH|MM)(hm|mh)(h|m){2,}(hm|mh)$";
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
         * d. Casais homossexuais mais velhos que os filhos, com pelo menos seis filhos, em que os dois primeiros filhos formam um casal e os últimos também:
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
