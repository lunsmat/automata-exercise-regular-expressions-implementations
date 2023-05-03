namespace Classes.Validators {
    interface IValidator {
        public string get_regex_pattern();
        public bool validate(string arg);
    }
}
