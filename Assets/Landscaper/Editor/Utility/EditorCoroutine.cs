using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;

namespace LandscaperEditor
{
	public sealed class EditorCoroutine
	{
		private IEnumerator coroutine;


		public EditorCoroutine(IEnumerator coroutine)
		{
			this.coroutine = coroutine;
			Start();
		}

		private void Start()
		{
			EditorApplication.update += OnUpdate;
		}

		private void Stop()
		{
			EditorApplication.update -= OnUpdate;
		}

		private void OnUpdate()
		{
			if (!coroutine.MoveNext())
				Stop();
		}


		#region Statics

		public static EditorCoroutine Start(IEnumerator coroutine)
		{
			return new EditorCoroutine(coroutine);
		}

		#endregion
	}

	public sealed class EditorWaitForCondition : IEnumerator
	{
		private Func<bool> conditionDelegate;


		public EditorWaitForCondition(Func<bool> conditionDelegate)
		{
			this.conditionDelegate = conditionDelegate;
		}

		public object Current { get { return conditionDelegate() ? null : this; } }

		public bool MoveNext()
		{
			return conditionDelegate();
		}

		public void Reset() { }
	}

	public sealed class EditorWaitForSeconds : IEnumerator
	{
		public bool IsComplete { get { return EditorApplication.timeSinceStartup - waitStartTime > secondsToWait; } }

		private double secondsToWait;
		private double waitStartTime;


		public EditorWaitForSeconds(double seconds)
		{
			secondsToWait = seconds;
			waitStartTime = EditorApplication.timeSinceStartup;
		}

		public object Current { get { return IsComplete ? null : this; } }

		public bool MoveNext()
		{
			return IsComplete;
		}

		public void Reset()
		{
			waitStartTime = EditorApplication.timeSinceStartup;
		}
	}
}
