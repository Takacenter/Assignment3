using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pmTweener : MonoBehaviour
{
    private pmTween activePacman;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activePacman != null)
        {


            if (Vector3.Distance(activePacman.Pacman.position, activePacman.pmEndPosition) > 0.1f)

            {

                activePacman.Pacman.position = Vector3.Lerp(activePacman.pmStartPosition, activePacman.pmEndPosition, (Time.time - activePacman.pmTime) / activePacman.pmDur);
               
            }
            if (Vector3.Distance(activePacman.Pacman.position, activePacman.pmEndPosition) <= 0.1f)
            {
                activePacman.Pacman.position = activePacman.pmEndPosition;
                activePacman = null;

            }
        }
    }

    public void AddPacMan(Transform pacmanObject, Vector3 pacmanPosition, Vector3 destination, float pmdur)
    {
        if (activePacman == null)
        {
            activePacman = new pmTween(pacmanObject, pacmanPosition, destination, Time.time, pmdur);

        }
    }
}
