using System;
using System.Collections.ObjectModel;
using System.IO;
using Avalonia.Controls;
using expander_test.Models;
using HarfBuzzSharp;
using ReactiveUI;

namespace expander_test.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _str;

    public string Str
    {
        get => _str;
        set => this.RaiseAndSetIfChanged(ref _str, value);
    }
    private string _currentNode;
    
    public string CurrentNode
    {
        get => _currentNode;
        set => this.RaiseAndSetIfChanged(ref _currentNode, value);
    }
    public ObservableCollection<Node> Nodes { get; } = new()
    {
        new Node("Маркировка оборудования и клемм", new ObservableCollection<Node>
        {
            new Node("NPP", new ObservableCollection<Node>
            {
                new Node("NPP-40x20"), new Node("NPP-20x10"), new Node("NPP-30x15")
            }),
            new Node("SMK", new ObservableCollection<Node>
            {
                new Node("SMK-DS,DC", new ObservableCollection<Node>()
                {
                    new Node("SMK-DS-2.5mm"), new Node("SMK-DS-4mm"), new Node("SMK-DS-6mm")
                }),
                new Node("SMK-PC(TB)"), new Node("SMK-OPK")
            }),
        })
    };

    public MainWindowViewModel()
    {
        
    }
}