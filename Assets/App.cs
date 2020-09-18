using Bones.TicTacToe;
using UnityEngine;

public class App : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var board = new TicTacToeBoard();
        var boardDisplay = new TicTacToeBoardDisplay(board);
        var game = new TicTacToe(board);

        game.PlayGame();
    }
}
