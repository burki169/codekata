int DistMoney(int money, int children) {
   if( money < children)
        return -1;
    if(money == children)
        return 0;
    money -= children;
    var eightTakers = Math.Min(money/7, children);
    money -= eightTakers * 7;

    if(money == 3  && children-eightTakers == 1)
        eightTakers--;
    else if(money >0 && children-eightTakers == 0)
        eightTakers--;
    return eightTakers;
}

Console.WriteLine( DistMoney(18,2));
