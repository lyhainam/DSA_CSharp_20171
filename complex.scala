/* Đỉnh cao của ngôn ngữ lập trình hướng đối tượng, quá đơn giản cho một bài tương đối lằng nhằng */


// Khai báo lớp Số phức và nạp chồng toán tử
class Complex(val re: Double, val im: Double) {
    def +(that: Complex) = 
        new Complex(this.re + that.re, this.im + that.im)

    def -(that: Complex) = 
        new Complex(this.re - that.re, this.im - that.im)

    def *(that: Complex) =
        new Complex(this.re * that.re - this.im * that.im, this.re * that.im + this.im * that.re)

    def /(that: Complex) =
        new Complex(this.re * that.re + this.im * that.im, that.re * that.re + that.im * that.im)

    override def toString = re + " + " + im + "i"
}

// Hàm Main()
object Complex {
    def main(args : Array[String]) : Unit = {
        var a = new Complex(4, 5)
        var b = new Complex(2, 3)
        println(a)  // 4.0 + 5.0i
        println(a + b)  // 6.0 + 8.0i
        println(a - b)  // 2.0 + 2.0i
        println(a * b)
        println(a / b)
    }
}