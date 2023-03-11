package com.mycompany.invertertexto;
import java.util.Scanner;



public class Invertertexto {

    public static void main(String[] args) {
        
        /*
        cria uma variavel string pega a entrada do usuario
        depois pega o ultimo indice da string e usa um for
        para começar a imprimir da ultima letra da string 
        de tras para frente.
        */
        
        String textoNormal = "";
        Scanner ler = new Scanner(System.in);  
        System.out.println("Escreva a palavra:");       
        textoNormal = ler.nextLine();
        for(int i =textoNormal.length()-1; i>=0;i--){
            System.out.print(textoNormal.charAt(i));
        }
                      
    }
        
}
