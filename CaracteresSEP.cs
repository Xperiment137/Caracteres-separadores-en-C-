// no sirve realmente para nada , es codigo sobrante pero con ideas de implementacion  que no quiero olvidar

// string text = " hola amigo  & 1-si & 2- no  # muy bien todo & hola otra vez ";

void InicioOpciones(int op)
    {
        string Fichero_Stri = fichero.text;
        char[] delimiterChars = { '#', '&' };
        string[] words = Fichero_Stri.Split(delimiterChars);
        int p = 0;
        int j = 0;
        string[] textos = new string[3];
        for (int t = 0; t < op; t++)
        {

            foreach (var word in words)
            {
                bool re = word.Contains(t + "-");

                if (re)
                {
                    textos[p++] = ($"<{word}>");


                }
            }

            foreach (var word in words)
            {
                bool re = word.Contains("-");

                if (!re)
                {
                    textos[p++] = ($"<{word}>");


                }
            }

        }
    }

    void InicioTextos()
    {
       
       
        char[] delimiterChars = { '#', '&' };
        string Fichero_Stri = fichero.text;
        string[] words = Fichero_Stri.Split(delimiterChars);
        int p = 0;
        int j = 0;
        foreach (var word in words)
        {
            bool re = word.Contains("-");
            if (!re)
            {
                j++;
            }
        }
        string[] textos = new string[j];


        foreach (var word in words)
        {
            bool re = word.Contains("-");

            if (!re)
            {
                textos[p++] = ($"<{word}>");


            }
        }

    }
}
