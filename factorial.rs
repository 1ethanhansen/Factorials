use std::io;

fn main() {
    let mut input_text = String::new();
        io::stdin()
                    .read_line(&mut input_text)
                            .expect("failed to read from stdin");

        let trimmed = input_text.trim();
            match trimmed.parse::<u32>() {
                        Ok(i) => factorial(i),
                                Err(..) => println!("this was not an integer: {}", trimmed),
            };
}

fn factorial(n: u32) {
    let mut counter = n;
    let mut total = 1;
    while counter > 0 {
            total *= counter;
                counter -= 1;
    }
    println!("{}! = {}", n, total);
}
