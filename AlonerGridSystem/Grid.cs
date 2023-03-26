namespace AlonerGridSystem;

public class Grid
{
    public int width
    {
        get {return gridCells[0].Count ;}
    }
    public int height
    {
        get {return gridCells.Count ;}
    }

    public List<List<GridCell>> gridCells;

    public Grid(int width, int height)
    {
        // if (width < 1 || height < 1)
        //     throw new Exception("width and height contains 0");
        gridCells = new List<List<GridCell>>(); 
        for (int y = 0; y < height; y++)
        {
            var gridCellsX = new List<GridCell>();
            for (int x = 0; x < width; x++)
            {
                gridCellsX.Add(new GridCell());
            }
            gridCells.Add(gridCellsX);
        }
    }
}