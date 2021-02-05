(ns factorial)
  
(defn bad-factorial [x] 
  (if (> x 1)
      (* (bad-factorial (dec x)) x)
      x))
      

(println (bad-factorial 6))
