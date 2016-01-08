using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveReader.Core.ViewModels
{
    public interface IFeedsViewModel
    {
        ReactiveList<BlogViewModel> Blogs { get; set; }
    }

    public class FeedsViewModel : ReactiveObject, IFeedsViewModel
    {
        public ReactiveList<BlogViewModel> Blogs { get; set; }
    }
}