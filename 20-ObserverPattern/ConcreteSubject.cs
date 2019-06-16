using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 具体的主题
    /// </summary>
    class ConcreteSubject : Subject
    {
        private string subjectState;
        private List<Observer> observerList = new List<Observer>();

        public string SubjectState { get { return subjectState; } set { subjectState = value; } }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="observer"></param>
        public override void Attach(Observer observer)
        {
            if (!observerList.Contains(observer))
            {
                observerList.Add(observer);
            }
        }

        /// <summary>
        /// 分离
        /// </summary>
        /// <param name="observer"></param>
        public override void Detach(Observer observer)
        {
            if (observerList.Contains(observer))
            {
                observerList.Remove(observer);
            }
        }

        /// <summary>
        /// 通知
        /// </summary>
        public override void Notify()
        {
            foreach (Observer observer in observerList)
            {
                observer.Update();
            }
        }
    }
}
