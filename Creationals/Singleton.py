from threading import Lock
class Singleton:
    instance = None
    #Simple implementation:
    def __new__(cls):
        if cls.instance is None:
            cls.instance = object.__new__(cls)
            return cls.instance

    #Thread safe implementation:
    def __new__(cls, lock):
        if cls.instance is None:
            with lock:
                if cls.instance is None:
                    cls.instance = object.__new__(cls)
        return cls.instance
