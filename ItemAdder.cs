using Inlämningsuppgift;

internal class ItemAdder
{
    public List<Mug> GetMugs()
    {
        List<Mug> mugs = new List<Mug>();

        Mug pappMugg = new Mug("Papermugar", "målar", 10, 15);
        mugs.Add(pappMugg);

        Mug resMugg = new Mug("Resmuggar", "sommar", 10, 154);
        mugs.Add(resMugg);

        Mug frukostMugg = new Mug("Frukostmuggar", "värlsens bästa moster", 5, 35);
        mugs.Add(frukostMugg);

        Mug unikaMug = new Mug("Unikamuggar", "disney", 0, 199);
        mugs.Add(unikaMug);

        Mug plastMugg1 = new Mug("Plasmuggar", "katt", 1, 20);
        mugs.Add(plastMugg1);


        Mug glasMug = new Mug("Glasmuggar", "landshopping", 8, 38);
        mugs.Add(glasMug);

        Mug KaffeMuggar = new Mug("Kaffemuggar", "hundar", 8, 54);
        mugs.Add(KaffeMuggar);


        Mug taMedMug = new Mug( "Ta med mugar","höns" ,4, 10);
        mugs.Add(taMedMug);

        Mug MetallMuggar = new Mug("Metallmuggar","ängen ", 7, 132);
        mugs.Add(MetallMuggar);
        
        Mug porslinsMuggar = new Mug("Porslinsmuggar", "moon", 6, 78);
        mugs.Add(porslinsMuggar);

        Mug keramikMuggarggar = new Mug("Keramikmuggarggar", "moon" ,5, 124); ;
        mugs.Add(keramikMuggarggar);

        return mugs;



       




}






    public List<Tshirt> GetTshirt()
    {
        List <Tshirt> tshirts= new List<Tshirt>();
        Tshirt barnTshirt = new Tshirt("T-shirt med Gorilla", "S,M,L,XL", "Linne", 195, 10);
        tshirts.Add(barnTshirt);


        Tshirt  barnTshirt1 = new Tshirt("Vit/Musse Pigg", "S,M,L,XL", "bomu", 99, 10);
        tshirts.Add(barnTshirt1);


        Tshirt barnTshirt2 = new Tshirt("T-shirt med Ugglor", "S,M,L,XL", "Polyester", 124, 9);
        tshirts.Add(barnTshirt2);

        Tshirt barnTshirt13 = new Tshirt("Ljusbeige/AC/DC", "S,M,L,XL", "bomull", 150, 9);
        tshirts.Add(barnTshirt13);


        Tshirt sportTshirt = new Tshirt("T-shirt med Manatee", "S,M,L,XL", "bomull",149, 8);
        tshirts.Add(sportTshirt);
        

        Tshirt sportTshirt1 = new Tshirt("T-shirt med Panda", "S,M,L,XL", " Konstsilke", 149, 8);
        tshirts.Add(sportTshirt1);


        Tshirt sportTshirt2 = new Tshirt("T-shirt med Val", "S,M,L,XL", "Polyester", 135, 8);
        tshirts.Add(sportTshirt2);

        Tshirt spoTshirt = new Tshirt("T-shirt med Tiger", "S,M,L,XL", "Linne", 159, 8);
        tshirts.Add(spoTshirt);
        return tshirts;




    }

    public List<Tshirt> SortShirts(List<Tshirt> shirts)
    {
        for (int i = 0; i < shirts.Count; i++)
        {
            for (int j = 0; j < shirts.Count - 1 - i; j++)
            {
                if (shirts[j].Snittbetyg > shirts[j + i].Snittbetyg)
                {
                    Tshirt tmp = new Tshirt(shirts[j + 1]);
                    shirts[j + 1] = shirts[j];
                    shirts[j] = tmp;
                }
            }
        }
        shirts.Reverse();
        return shirts;
    }



    public List<Mug> SortMugs(List<Mug> mugs)
    {
        for (int i = 0; i < mugs.Count; i++)
        {
            for (int j = 0; j < mugs.Count - 1 - i; j++)
            {
                if (mugs[j].Snittbetyg > mugs[j + i].Snittbetyg)
                {
                    Mug tmp = new Mug(mugs[j + 1]);
                    mugs[j + 1] = mugs[j];
                    mugs[j] = tmp;
                }
            }
        }
        return mugs;
    }

}