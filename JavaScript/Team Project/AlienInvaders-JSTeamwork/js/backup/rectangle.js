/**
 * Created by Bi0GaMe on 21.7.2014 г..
 */
//Start of Rectangle class
Rectangle =  function(x,y,w,h){
    if(x == null||y==null||w==null||h==null){
        alert("you did not pass all the required variables");

        var errorMsg = "Missing:"
        if(x==null) errorMsg += " 'x' ";
        if(y==null) errorMsg += " 'y' ";
        if(w==null) errorMsg += " 'w' ";
        if(h==null) errorMsg += " 'h' ";

        throw new Error(errorMsg);
    }

    this.x = x;
    this.y = y;
    this.width = w;
    this.height = h;

    this.color = new Color();

    this.Intersects = function(shape){
        var offset = 0;
        if (shape.radius != null) offset = shape.radius;

        if(this.Contains(shape.x - offset, shape.y - offset) ||
            this.Contains(shape.x + shape.width - offset, shape.y - offset)||
            this.Contains(shape.x - offset, shape.y+shape.height - offset)||
            this.Contains(shape.x + shape.width - offset, shape.y+shape.height - offset)){
            return true;
        }
        else if(shape.Contains(this.x - offset, this.y - offset) ||
            shape.Contains(this.x + this.width - offset, this.y - offset)||
            shape.Contains(this.x - offset, this.y + this.height - offset)||
            shape.Contains(this.x + this.width - offset, this.y + this.height - offset)){
            return true;
        }
        return false;
    };

    this.Contains = function(x,y) {
        if(x >= this.x && x <= this.x + this.width &&
            y >= this.y && y <= this.y + this.height)
        {
            return true;
        }
        else
            return false;
    };

    this.Draw = function(ctx){
        ctx.fillStyle = this.color.ToStandard();
        ctx.fillRect(this.x, this.y, this.width, this.height);

    };
}; //End of Rectangle class