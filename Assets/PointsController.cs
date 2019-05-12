using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsController : MonoBehaviour{
    Vector3 foodPos;
    Vector3 foodRotation;
    public TextMesh foodText;
    public static int puntaje = 0;
    public TextMesh textoPuntaje;

    // Start is called before the first frame update
    void Start(){
        foodPos = this.transform.position;
        foodRotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update(){
        if(this.transform.position.y < -3.0 ){ // Esto significa que está debajo del plano, el jugador no le atino al hombre gordo.
            fail();
            resetFood();
        }
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "Fat Guy"){
            revisarSiComidaCorrecta();       
            resetFood();
        }
    }

    void revisarSiComidaCorrecta(){
        if(this.name == "Cheese" && foodText.GetComponent<TextMesh>().text == "Lácteo!"){
            score();
        }
        else if(this.name == "Banana" && foodText.GetComponent<TextMesh>().text == "Fruta!"){
            score();
        }
        else if(this.name == "Tomato" && foodText.GetComponent<TextMesh>().text == "Verdura!"){
            score();
        }
        else if(this.name == "Steak" && foodText.GetComponent<TextMesh>().text == "Proteína!"){
            score();
        }
        else if(this.name == "IceCream" && foodText.GetComponent<TextMesh>().text == "Azúcares!"){
            score();
        }
        else if(this.name == "Avocado" && foodText.GetComponent<TextMesh>().text == "Lípidos!"){
            score();
        }
        else if(this.name == "Onigiri" && foodText.GetComponent<TextMesh>().text == "Cereal!"){
            score();
        }else{
        	fail();
        }
    }

    void cambiarTexto(){
        var randomInt = Random.Range(0,7);
        if(randomInt == 0){
            foodText.GetComponent<TextMesh>().text = "Cereal!";
        }
        else if(randomInt == 1){
            foodText.GetComponent<TextMesh>().text = "Proteína!";
        }
        else if(randomInt == 2){
            foodText.GetComponent<TextMesh>().text = "Fruta!";
        }
        else if(randomInt == 3){
            foodText.GetComponent<TextMesh>().text = "Verdura!";
        }
        else if(randomInt == 4){
            foodText.GetComponent<TextMesh>().text = "Lípidos!";
        }
        else if(randomInt == 5){
            foodText.GetComponent<TextMesh>().text = "Lácteo!";
        }
        else if(randomInt == 6){
            foodText.GetComponent<TextMesh>().text = "Azúcares!";
        }
        else{
            foodText.GetComponent<TextMesh>().text = "Fruta!";
        }
    }

    void resetFood(){
        this.transform.position = foodPos;
        this.transform.eulerAngles = foodRotation;
        this.GetComponent<Rigidbody>().AddForce(0f,0f,0f);
        this.GetComponent<Rigidbody>().isKinematic = true;
    }

    void score(){
        puntaje = puntaje + 10; 
        cambiarTexto();
        textoPuntaje.GetComponent<TextMesh>().text = puntaje + " Puntos";
        if(puntaje >= 100){
            resetPoints();
            goToWin();
        }
    }

    void fail(){
        puntaje = puntaje - 10;
        textoPuntaje.GetComponent<TextMesh>().text = puntaje + " Puntos";
        if(puntaje < 0){
            resetPoints();
            goToFail();
        }
    }

    void goToWin(){
        Application.LoadLevel("WinScene");
    }

    void goToFail(){
        Application.LoadLevel("FailScene");
    }

    public void resetPoints(){
        puntaje = 0;
    }
    
}