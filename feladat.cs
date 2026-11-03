// Jelszó-erősség mérő

int jelszo_erosseg(string jelszo, int ero)
{
    if (jelszo.Count() >= 5)
    {
        ero++;
        return ero;
    }
    else if (jelszo.Count() >= 8)
    {
         ero++;
         return ero + 1;
    }
    else if (jelszo == "_")
    {
        ero++;
        return ero + 1;
    }
    else if (jelszo == "jelszo")
    {
        ero--;
        return ero;
    }
    else if (jelszo == "123")
    {
        ero--;
        return ero;
    }
    else if (jelszo.Count() == 0)
    {
        ero--;
        return ero;
    }
}
Console.WriteLine(jelszo_erosseg("aa", 1));