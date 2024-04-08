public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else if (Left.Data != value)
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else  if (Right.Data != value)
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        
        if (value < Data) {
            if (Left != null)
                if (value == Left.Data)
                    return true;
                else if (Left.Contains(value))
                    return true;
        }
        else {
            if (Right != null)
                if (value == Right.Data)
                    return true;
                else if (Right.Contains(value)) 
                    return true;            
        }
        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        int counterLeft = 1;
        int counterRight = 1;
        if (Left != null)
            counterLeft += Left.GetHeight();
        if (Right != null)
            counterRight += Right.GetHeight();
        
        if (counterLeft > counterRight)
            return counterLeft;
        
        return counterRight; // Replace this line with the correct return statement(s)
    }
}