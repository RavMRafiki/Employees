using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracownicy.Presenter
{
    class MainPresenter
    {
        private View.Form1 _view;
        private Model.MainModel _model;
        public MainPresenter(View.Form1 view, Model.MainModel model)
        {
            _view = view;
            _model = model;
        }
    }
}
