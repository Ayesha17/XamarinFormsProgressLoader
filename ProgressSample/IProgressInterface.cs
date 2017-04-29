using System;

namespace ProgressSample
{
	public interface IProgressInterface
	{
		void Show(string title = "Loading");

		void Hide();
	}
}
