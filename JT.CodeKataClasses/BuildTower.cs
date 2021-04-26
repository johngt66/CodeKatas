using System;
public class BuildTower
{
    public static string[] TowerBuilder(int nFloors)
    {
        string[] tower = new string[nFloors];

        for(int i = 0; i < nFloors; i++)
            tower[i] = $"{new string(' ',nFloors-i-1)}{new string('*',(i+1)*2-1)}{new string(' ',nFloors-i-1)}";

        return tower;
     }
}
