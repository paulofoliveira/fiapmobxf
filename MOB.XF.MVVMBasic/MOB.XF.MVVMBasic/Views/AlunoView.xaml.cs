using MOB.XF.MVVMBasic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.MVVMBasic.Views
{
    public partial class AlunoView : ContentPage
    {
        AlunoViewModel vmAluno;

        public AlunoView()
        {
            var aluno = AlunoViewModel.GetAluno();
            vmAluno = new AlunoViewModel(aluno);
            BindingContext = vmAluno;
            InitializeComponent();
        }
    }
}
