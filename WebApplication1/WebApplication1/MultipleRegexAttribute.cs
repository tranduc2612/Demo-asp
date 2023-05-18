using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

public class RegexValidation
{
    public string Pattern { get; set; }
    public string ErrorMessage { get; set; }
}

public class MultipleRegexAttribute : ValidationAttribute
{
    private readonly List<RegexValidation> _regexValidations;

    public MultipleRegexAttribute(params RegexValidation[] regexValidations)
    {
        _regexValidations = regexValidations.ToList();
    }

    public override bool IsValid(object value)
    {
        if (value == null)
        {
            return true;
        }

        string input = value.ToString();

        foreach (var regexValidation in _regexValidations)
        {
            if (Regex.IsMatch(input, regexValidation.Pattern))
            {
                return true;
            }
        }

        ErrorMessage = "The input does not match any of the specified patterns.";
        return false;
    }
}
