using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var result = new StringBuilder();
        bool capitalizeNext = false;

        foreach (char c in identifier)
        {
            if (char.IsControl(c))
            {
                result.Append("CTRL");
                capitalizeNext = false;
            }
            else if (c == ' ')
            {
                result.Append('_');
                capitalizeNext = false;
            }
            else if (c == '-')
            {
                capitalizeNext = true;
            }
            else
            {
                char current = capitalizeNext ? char.ToUpper(c) : c;
                capitalizeNext = false;

                bool isGreekLower = current >= 'α' && current <= 'ω';

                if (char.IsLetter(current) && !isGreekLower)
                {
                    result.Append(current);
                }
            }
        }

        return result.ToString();
    }
}