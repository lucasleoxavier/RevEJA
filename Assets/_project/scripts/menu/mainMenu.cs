﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class mainMenu : MonoBehaviour {

    //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
    //Logos do menu inicial
    public GameObject logoCreatura;
    public GameObject logoReveja;
    public GameObject textModosDeJogo;
    //Botoes do menu
    public GameObject botaoJogar;
    public GameObject botaoConfig;
    public GameObject botaoSair;
    public GameObject botaoComoJogar;
    //Botoes dos modos de jogo
    public GameObject btNiveis;
    public GameObject btAmpulheta;
    //Botao para voltar ao menu anterior
    public GameObject btVoltar;
    //Botao do modo de jogo ampulheta
    public GameObject btAmpulhetaIniciar;
    public GameObject textModoJogoAmpulheta;
    public GameObject textDescricaoAmpulheta;
    //Botao do modo de jogo niveis
    public GameObject textModoJogoNiveis;
    public GameObject textDescricaoNiveis;
    public GameObject btNivelBasico;
    public GameObject btNivelAvancado;
    public GameObject btPortBasico;
    public GameObject btPortAvancado;
    public GameObject btMathBasico;
    public GameObject btMathAvancado;
    //variaveis para tocar som no botao
    public AudioSource audioSourceBotao;
    public AudioClip somBotao;
    //label para os creditos
    public GameObject lbComoJogar;
    public GameObject lbCreditos;
    public GameObject btSairCreditos;
    //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*



    // Use this for initialization
    public void Start () {
        //Exibe elementos iniciais da tela
        logoCreatura.SetActive(true);
        logoReveja.SetActive(true);
        botaoJogar.SetActive(true);
        botaoConfig.SetActive(true);
        botaoSair.SetActive(true);
        botaoComoJogar.SetActive(true);
        //Esconde modos de jogo e botao voltar
        btVoltar.SetActive(false);
        btAmpulheta.SetActive(false);
        btNiveis.SetActive(false);
        textModosDeJogo.SetActive(false);
        btAmpulhetaIniciar.SetActive(false);
        textModoJogoAmpulheta.SetActive(false);
        textDescricaoAmpulheta.SetActive(false);
        textModoJogoNiveis.SetActive(false);
        btAmpulhetaIniciar.SetActive(false);
        textDescricaoNiveis.SetActive(false);
        btNivelBasico.SetActive(false);
        btNivelAvancado.SetActive(false);
        btPortAvancado.SetActive(false);
        btPortBasico.SetActive(false);
        btMathAvancado.SetActive(false);
        btMathBasico.SetActive(false);
        lbComoJogar.SetActive(false);
        lbCreditos.SetActive(false);
        btSairCreditos.SetActive(false);
        //UI de configurações


    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //Fecha o jogo
    public void Sair()
    {
        Application.Quit();
    }

    //Abre os modos de jogo, escondendo o menu anterior
    public void JogarInicial()
    {
        //Esconder elementos iniciais da tela
        logoCreatura.SetActive(false);
        logoReveja.SetActive(false);
        botaoJogar.SetActive(false);
        botaoConfig.SetActive(false);
        botaoSair.SetActive(false);
        botaoComoJogar.SetActive(false);
        //Exibe modos de jogo e botao voltar
        btVoltar.SetActive(true);
        btAmpulheta.SetActive(true);
        btNiveis.SetActive(true);
        textModosDeJogo.SetActive(true);
    }

    //Abre as configurações de tela e som
    public void AbrirConfiguracoes()
    {
        SceneManager.LoadScene("config");
    }

    public void ComoJogar()
    {
        //esconde no HUD
        logoCreatura.SetActive(false);
        logoReveja.SetActive(false);
        botaoJogar.SetActive(false);
        botaoConfig.SetActive(false);
        botaoSair.SetActive(false);
        botaoComoJogar.SetActive(false);
        btVoltar.SetActive(false);
        //exibe botão voltar        
        btSairCreditos.SetActive(true);
        //exibe créditos
        lbComoJogar.SetActive(true);
        lbCreditos.SetActive(true);
    }

    public void SairTelaCreditos()
    {
        //Exibe elementos iniciais da tela
        logoCreatura.SetActive(true);
        logoReveja.SetActive(true);
        botaoJogar.SetActive(true);
        botaoConfig.SetActive(true);
        botaoSair.SetActive(true);
        botaoComoJogar.SetActive(true);
        //Esconde modos de jogo e botao voltar
        btVoltar.SetActive(false);
        btAmpulheta.SetActive(false);
        btNiveis.SetActive(false);
        textModosDeJogo.SetActive(false);
        btAmpulhetaIniciar.SetActive(false);
        textModoJogoAmpulheta.SetActive(false);
        textDescricaoAmpulheta.SetActive(false);
        textModoJogoNiveis.SetActive(false);
        btAmpulhetaIniciar.SetActive(false);
        textDescricaoNiveis.SetActive(false);
        btNivelBasico.SetActive(false);
        btNivelAvancado.SetActive(false);
        btPortAvancado.SetActive(false);
        btPortBasico.SetActive(false);
        btMathAvancado.SetActive(false);
        btMathBasico.SetActive(false);
        lbComoJogar.SetActive(false);
        lbCreditos.SetActive(false);
        btSairCreditos.SetActive(false);
    }

    public void ModoAmpulheta()
    {
        btAmpulhetaIniciar.SetActive(true);
        btVoltar.SetActive(true);
        textModoJogoAmpulheta.SetActive(true);
        textDescricaoAmpulheta.SetActive(true);
        //Desliga o menu anterior, deixando só o botao Voltar
        btVoltar.SetActive(true);
        btAmpulheta.SetActive(false);
        btNiveis.SetActive(false);
        textModosDeJogo.SetActive(false);


    }

    public void ModoNiveis()
    {
        btVoltar.SetActive(true);
        textModoJogoNiveis.SetActive(true);
        textDescricaoNiveis.SetActive(true);
        btNivelBasico.SetActive(true);
        btNivelAvancado.SetActive(true);
        //Desliga o menu anterior, deixando só o botao Voltar       
        btAmpulheta.SetActive(false);
        btNiveis.SetActive(false);
        textModosDeJogo.SetActive(false);
    }

    public void NivelBasico()
    {
        btNivelBasico.SetActive(false);
        btNivelAvancado.SetActive(false);

        btPortBasico.SetActive(true);
        btMathBasico.SetActive(true);
    }

    public void NivelAvancado()
    {
        btNivelBasico.SetActive(false);
        btNivelAvancado.SetActive(false);

        btPortAvancado.SetActive(true);
        btMathAvancado.SetActive(true);

    }

    public void ampulhetaStart()
    {
        SceneManager.LoadScene("jogo");
        logicaJogo.modoJogo = 0;
    }

    public void mathBasicStart()
    {
        SceneManager.LoadScene("jogo");
        logicaJogo.modoJogo = 1;
    }

    public void mathAvancStart()
    {
        SceneManager.LoadScene("jogo");
        logicaJogo.modoJogo = 2;
    }

    public void portBasicStart()
    {
        SceneManager.LoadScene("jogo");
        logicaJogo.modoJogo = 3;
    }

    public void portAvancStart()
    {
        SceneManager.LoadScene("jogo");
        logicaJogo.modoJogo = 4;
    }

    public void SomBotao()
    {
        audioSourceBotao.clip = somBotao;
        audioSourceBotao.Play();
    }
}
