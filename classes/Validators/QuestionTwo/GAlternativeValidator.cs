using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class GAlternativeValidator: IValidator
    {
        private int x = 0;
        private int y = 0;

        public GAlternativeValidator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string get_regex_pattern()
        {
            return $"^(H|M){"{" + this.x + "," + this.y + "}"}((h|m){"{0,2}"}|(h*m*)*mh{"{0,2}"})$";
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
         * g. Arranjo de no mínimo x∈ℕ e no máximo y∈ℕ , com x>0 , y>0 , e x≤y , de adultos (Hs ou Ms) mais velhos que os filhos, com qualquer quantidade de filhos homens e mulheres, mas que os três filhos mais novos não foram homens:
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
