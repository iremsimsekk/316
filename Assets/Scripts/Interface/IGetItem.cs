public enum ItemType
{
    TOMATO,LETTUCE,ONION,CHEESE,MEATBALL,BREAD,NONE,
    SLICEDTOM,SLICEDLET,SLICEDON,SLICEDCHE,COOKEDMEAT,SLICEDBREAD,PLATE,SlICEDBREADTOP,HAMBURGER,SYRUP,COFFEE1,COFFEE2,MILK,GROUNDCOFFEE,ESPRESSOMODEL,MILKCUP,LATTE,CAKE,ESPRESSO,GROUNDCOFFEE2,AMERICANO,TEA,TEAFULL
}
public interface IGetItem
{
    public ItemType GetItem();
} 
