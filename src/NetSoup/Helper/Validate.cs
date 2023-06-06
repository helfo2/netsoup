namespace NetSoup.Helper;

public static class Validate
{
    public static void NotNull(object? obj)
    {
        if (obj == null)
        {
            throw new NullReferenceException("Object must not be null");
        }
    }

    public static void NotNullParam(object? obj, string param)
    {
        if (obj == null)
        {
            throw new ArgumentNullException($"The parameter {param} must not be null");
        }
    }

    public static void NotNull(object? obj, string msg)
    {
        if (obj == null)
        {
            throw new NullReferenceException(msg);
        }
    }

    public static object EnsureNotNull(object? obj, string msg)
    {
        if (obj == null)
        {
            throw new NullReferenceException(msg);
        }
        else
        {
            return obj;
        }
    }

    public static void IsTrue(bool value, string msg)
    {
        if (!value)
        {
            throw new InvalidDataException(msg);
        }
    }

    public static void IsFalse(bool value)
    {
        if (value)
        {
            throw new InvalidDataException("Must be false");
        }
    }

    public static void IsFalse(bool value, string msg)
    {
        if (value)
        {
            throw new InvalidDataException(msg);
        }
    }

    public static void NoNullElements(object[] objs)
    {
        NoNullElements(objs, "Array must not contain any null objects");
    }

    public static void NoNullElements(object[] objs, string msg)
    {
        foreach (var obj in objs)
        {
            if (obj == null)
            {
                throw new NullReferenceException(msg);
            }
        }
    }

    public static void NotEmpty(string? str)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new InvalidDataException("String must not be empty");
        }
    }

    public static void NotEmpty(string? str, string param = "", string msg = "")
    {
        if (string.IsNullOrEmpty(param) && string.IsNullOrEmpty(msg))
        {
            throw new ArgumentException("Choose a parameter name or a message to use this validation");
        }

        if (string.IsNullOrEmpty(str))
        {
            if (!string.IsNullOrEmpty(param))
            {
                throw new InvalidDataException($"The '{param}' parameter must not be empty");
            }

            if (!string.IsNullOrEmpty(msg))
            {
                throw new InvalidDataException(msg);
            }
        }
    }

    public static void Wtf(string msg)
    {
        throw new NotSupportedException(msg);
    }

    public static void Fail(string msg)
    {
        throw new InvalidDataException(msg);
    }

    public static bool AssertFail(string msg)
    {
        Fail(msg);
        return false;
    }
}
