Unity Grid Generator
====================

A simple Unity script, that computes a grid for tile-based 2D-Games.

## Usage

Align all your tiles in a grid and assign them as childs to an empty game object, which is representing the tile-map.

![Example](example.jpg?raw=true "Example")

Mark every wall or obstacle with the tag "Wall".

Add GridGenerator.cs to your tile-map object.

Start the game. You should see a message like this in the console:

```
Grid:
1 1 1 1 1 1 1 1 1 1 1 1
1 1 1 1 1 1 1 1 1 1 1 1
1 0 0 0 0 0 0 0 0 0 0 1
1 0 0 0 0 0 0 1 0 0 0 1
1 0 0 1 0 0 1 1 1 1 1 1
1 0 1 1 1 0 1 1 1 1 1 1
1 0 1 1 1 0 1 0 0 0 0 1
1 0 0 1 0 0 1 0 0 1 0 1
1 0 0 1 0 0 0 0 0 1 0 1
1 0 0 1 0 0 0 0 0 0 0 1
1 1 1 1 1 1 1 1 1 1 1 1
```

GridGenerator.cs has a getter for the Grid:

```csharp
public GridTile[,] Grid {
    get {
        return grid;
    }
}
```

That's it! Have fun! :-)
