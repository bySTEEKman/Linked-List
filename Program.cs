using System;

namespace linkedList
{
    public class LinkedList {
        private ListNode head;
        private ListNode tail;
        private int size;

        class ListNode {
            public string value;
            public ListNode nextNode;

            public ListNode(string value) {
                this.value = value;
            }
        }

        public string getFirst() {
            return head.value;
        }

        public int getSize() {
            return size;
        }

        public void addItem(string value) {
            ListNode newNode = new ListNode(value);
            if (tail == null) { // empty list
                head = newNode;
            } else { // has at least one element
                tail.nextNode = newNode;
            }
            size++;
            tail = newNode;
        }
        public void addItemToStart(string value){
            ListNode newNode = new ListNode(value);
            if (head == null){
                head = newNode;
                tail = newNode;
            } else {
                tail = head;
                head = newNode;
                head.nextNode = tail;
            }
            size++;
        }
        public string getElementByIndex(int index) {
            int i = 0;
            for (ListNode node = head; node != null; node = node.nextNode) {
                i++;
                if(i == index){
                    return node.value;
                }
            }
            return null;
        }
        public void replaceElement(int index, string newValue) {
            int i = 0;
            for (ListNode node = head; node != null; node = node.nextNode) {
                i++;
                if(i == index){
                    node.value = newValue;
                }
            }
        }
        public void removeElement(int index) {
            int i = 0;
            for (ListNode node = head; node != null; node = node.nextNode) {
                i++;
                if(i + 1 == index){
                    node.nextNode = node.nextNode.nextNode;
                    size--;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList newList = new LinkedList();
            newList.addItem("first");
            newList.addItemToStart("second");
            newList.addItem("third");
            newList.addItem("fourth");
            newList.addItem("the fifth");
            newList.replaceElement(4, "Hello Linled List");
            newList.removeElement(3);
            Console.WriteLine($"{newList.getElementByIndex(5)} {newList.getSize()}");
        }
    }
}
