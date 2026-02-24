using UnityEngine;

public class Vida : MonoBehaviour
{
    [Header("Configuração de Vida")]
    [SerializeField] private int vidaMaxima = 100;

    [Header("Status Atual")]
    [SerializeField] private int vidaAtual;

    private void Awake()
    {
        vidaAtual = vidaMaxima;
    }
}