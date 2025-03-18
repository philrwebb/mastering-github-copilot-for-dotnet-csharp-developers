using System;

namespace Skills;

public class Comments
{
    // create a method that generates a comment for a given skill
    public string GetSkillComment(string skill)
    {
        // return a comment based on the skill
        switch (skill)
        {
            case "C#":
                return "C# is a powerful language for building Windows applications.";
            case "JavaScript":
                return "JavaScript is the language of the web.";
            case "Python":
                return "Python is a versatile language used for web development, data analysis, and more.";
            default:
                return "Unknown skill.";
        }
    }



}
