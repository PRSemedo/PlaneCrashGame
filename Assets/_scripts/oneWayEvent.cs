using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneWayEvent : MonoBehaviour
{



    bool actived;

    float timer;

    [SerializeField] float eixo;
    [SerializeField] float eixoLength;
    [SerializeField] float speed;

    bool firstLoop;


    int direcao;

    bool leftInp;
    bool rightInp;

    inputting input;
    void Start()
    {

    }


    void Update()
    {
        if (!firstLoop)
        {
            firstLoop = true;

            input = inputting.instance;

        }


        if (actived)
        {

            inputReceiver();
            activation();


        }


    }

    public void inputReceiver()
    {

        leftInp = input.leftButton;
        rightInp = input.rightButton;





    }

    public void receiver(scriptableSound som)
    {

        actived = true;
        timer = som.timing;
        direcao = som.direcao;
        eixo = 0;

       
    }

    public void activation()
    {
        timer -= Time.deltaTime;

        if (timer > 0)
        {

            if (leftInp)
            {
                eixo -= speed * Time.deltaTime;



            }
            if (rightInp)
            {
                eixo += speed * Time.deltaTime;

            }




        }


        if (timer <= 0)
        {
            

            eventMannager.instance.receive(1);


            actived = false;


        }



        if(direcao == -1)
        {


            if(eixo <= -eixoLength)
        {

                eventMannager.instance.receive(0);


                actived = false;


            }


        }
        if(direcao == 1)
        {

if (eixo >= eixoLength )
        {

            eventMannager.instance.receive(0);


            actived = false;


        }

        }

        



    }


    public void deactivate()
    {


        actived = false;

    }
}
