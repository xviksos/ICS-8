using System;

namespace Lab6TemplateMethod.Drink
{
    public abstract class haircut
    {
        // ����������� �����
        protected haircut(string type) => Type = type;

        public string Type { get;}

        protected abstract void Prepare();

        protected abstract void Cutting();

        private void PourInto()
        {
            Console.WriteLine("����� ���� �������� -��� {0}", Type);
        }
        //��������� ����� - ������ ������� �������� ��������
        public void Make()
        { 
            Prepare();
            Cutting();
            PourInto();
        }
    }
}